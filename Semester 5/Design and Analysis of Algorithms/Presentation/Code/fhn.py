import time

class HighUtilityItemset:
    def __init__(self, itemset, utility):
        self.itemset = itemset
        self.utility = utility

class FHNAlgorithm:
    def __init__(self, k):
        self.kItemsets = []
        self.k = k
        self.totalTime = 0

    def read_transactions(self, file_path):
        transactions = []
        with open(file_path, 'r') as file:
            for line in file:
                line = line.strip()
                if not line:
                    continue
                parts = line.split(':')
                items = list(map(int, parts[0].split()))
                transaction_utility = int(parts[1])
                item_utilities = list(map(int, parts[2].split()))
                transactions.append((items, transaction_utility, item_utilities))
        return transactions

    def calculate_utility(self, itemset, transactions):
        total_utility = 0
        for items, _, item_utils in transactions:
            if all(item in items for item in itemset):
                total_utility += sum(item_utils[items.index(item)] for item in itemset)
        return total_utility

    def generate_itemsets(self, items, length):
        if length == 0:
            return [[]]
        all_itemsets = []
        for i in range(len(items)):
            current = items[i]
            rest = items[i + 1:]
            for sub_itemset in self.generate_itemsets(rest, length - 1):
                all_itemsets.append([current] + sub_itemset)
        return all_itemsets

    def fhn_algorithm(self, transactions, min_utility):
        items = set(item for trans in transactions for item in trans[0])
        max_length = min(len(items), 3)  # Giới hạn chiều dài tối đa
        for length in range(1, max_length + 1):
        # for length in range(1, len(items) + 1):
            for itemset in self.generate_itemsets(list(items), length):
                utility = self.calculate_utility(itemset, transactions)
                if utility >= min_utility:
                    self.kItemsets.append(HighUtilityItemset(itemset, utility))

    def print_stats(self):
        print(f"=============  FHN - Python version  =============")
        print(f" High-utility itemsets count : {len(self.kItemsets)}")
        print(f" Total time ~ {self.totalTime:.2f} seconds")
        print(f" High-utility itemsets (Top {self.k}):")
        for itemset in sorted(self.kItemsets, key=lambda x: x.utility, reverse=True)[:self.k]:
            print(f"Itemset: {itemset.itemset}, Utility: {itemset.utility}")
        print(f"=========================================================")

def main():
    file_path = 'mushroom.txt'
    min_utility = 0
    k = 10  # Change this to the desired number of top itemsets

    algorithm = FHNAlgorithm(k)
    transactions = algorithm.read_transactions(file_path)

    start_time = time.time()
    algorithm.fhn_algorithm(transactions, min_utility)
    algorithm.totalTime = time.time() - start_time

    algorithm.print_stats()

if __name__ == "__main__":
    main()