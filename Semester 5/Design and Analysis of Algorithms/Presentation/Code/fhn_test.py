class HighUtilityItemset:
    def __init__(self, itemset, utility):
        self.itemset = itemset
        self.utility = utility

class FHNAlgorithm:
    def __init__(self, min_utility):
        self.min_utility = min_utility
        self.high_utility_itemsets = []

    def read_transactions(self, file_path):
        transactions = []
        with open(file_path, 'r') as f:
            for line in f:
                parts = line.strip().split(':')
                # Trích xuất các thông tin riêng biệt
                item_ids = list(map(int, parts[0].split(',')))  # Changed items to item_ids
                utility = int(parts[1])
                item_attributes = list(map(int, parts[2].split(',')))
                transactions.append((item_ids, utility, item_attributes))
        return transactions

    def calculate_utility(self, itemset, transactions):
        utility = 0
        for transaction in transactions:
            if all(item in transaction[0] for item in itemset):
                utility += transaction[1]
        return utility

    def generate_itemsets(self, items, length):
        if length == 0:
            return [[]]
        itemsets = []
        for i in range(len(items)):
            for subset in self.generate_itemsets(items[:i] + items[i+1:], length-1):
                itemsets.append([items[i]] + subset)
        return itemsets

    def fhn_algorithm(self, transactions):
        items = set(item for transaction in transactions for item in transaction[0])
        for length in range(1, len(items) + 1):
            for itemset in self.generate_itemsets(list(items), length):
                utility = self.calculate_utility(itemset, transactions)
                if utility >= self.min_utility:
                    self.high_utility_itemsets.append(HighUtilityItemset(itemset, utility))

    def print_results(self):
        for itemset in self.high_utility_itemsets:
            print(f"Itemset: {itemset.itemset}, Utility: {itemset.utility}")

# Example usage
algorithm = FHNAlgorithm(min_utility=10)
transactions = algorithm.read_transactions('sample.txt')
algorithm.fhn_algorithm(transactions)
algorithm.print_results()