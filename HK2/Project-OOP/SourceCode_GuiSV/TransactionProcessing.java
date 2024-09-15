import java.util.*;
import java.io.*;

public class TransactionProcessing 
{
    private ArrayList<Payment> paymentObjects;
    private IDCardManagement idcm;
    
    public TransactionProcessing(String idCardPath, String paymentPath) 
    {
        idcm = new IDCardManagement(idCardPath);
        readPaymentObject(paymentPath);
    
    }

    public ArrayList<Payment> getPaymentObject() 
    {
        return this.paymentObjects;
    }

    // Requirement 3
    public boolean readPaymentObject(String path) 
    {
        ArrayList<IDCard> idcs = idcm.getIDCards();
        try 
        {
            paymentObjects = new ArrayList<>();

            File f1 = new File(path);
            Scanner sc1 = new Scanner(f1);

            while (sc1.hasNextLine()) 
            {
                String l1 = sc1.nextLine();
                String[] p1 = l1.split(",");

                if (p1.length == 1 && l1.length() == 6) 
                {  
                    for (IDCard idc : idcs)
                    {
                        if (l1.equals(String.valueOf(idc.getSDD())))
                        {
                            try 
                            {
                                ConvenientCard cc = new ConvenientCard(idc);
                                paymentObjects.add(cc);
                            } 
                            catch (CannotCreateCard exception) 
                            {
                                System.out.println(exception);
                            }
                        }
                        
                    }
                } 
                else if (p1.length == 1 && l1.length() == 7) 
                {
                    EWallet ew = new EWallet(Integer.parseInt(p1[0]));
                    paymentObjects.add(ew);
                } 
                else if (p1.length == 2) 
                {
                    BankAccount bac = new BankAccount(Integer.parseInt(p1[0]), Double.parseDouble(p1[1]));
                    paymentObjects.add(bac);
                }
            }
            sc1.close();
            return true;
        } 
        catch (IOException exception) 
        {
            exception.printStackTrace();
            return false;
        }
    }

    // Requirement 4
    public ArrayList<ConvenientCard> getAdultConvenientCards() 
    {
        //code here
        ArrayList<ConvenientCard> adultC = new ArrayList<>();
        for (Payment pay : paymentObjects) 
        {
            if (pay instanceof ConvenientCard) 
            {
                ConvenientCard cc = (ConvenientCard) pay;
                if (cc.getType().equals("Adult")) 
                {
                    adultC.add(cc);
                }
            }
        }
        if (adultC.isEmpty()) 
        {
            return null;
        } 
        else 
        {
            return adultC;
        }
    }
    
    // Requirement 5
    public ArrayList<IDCard> getCustomersHaveBoth() 
    {
        //code here
        ArrayList<IDCard> customer = new ArrayList<>();
        ArrayList<IDCard> idcs = idcm.getIDCards();
        
        for (IDCard idc : idcs)
        {   
            for (Payment pay : paymentObjects)
            {   
                if (pay instanceof ConvenientCard)
                {   
                    ConvenientCard cc = (ConvenientCard) pay;
                    int sdt = idc.getSDT();
                    int sdd = idc.getSDD();
                    if (cc.getSDD() == sdd)
                    {
                        for (Payment p1 : paymentObjects)
                        {
                            if (p1 instanceof EWallet)
                            {
                                EWallet ew = (EWallet) p1;
                                if (ew.getSDT() == sdt)
                                {            
                                    for (Payment p2 : paymentObjects)
                                    {
                                        if (p2 instanceof BankAccount)
                                        {
                                            BankAccount ba = (BankAccount) p2;
                                            if (ba.getSTK() == sdd)
                                            {
                                                customer.add(idc);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }    
                }
            }
        }
        return customer;
    }   
    // Requirement 6
    public void processTopUp(String path) 
    {
        //code here
        try 
        {

            File f1 = new File(path);
            Scanner sc1 = new Scanner(f1);

            while (sc1.hasNextLine()) 
            {
                String l1 = sc1.nextLine();
                String[] p1 = l1.split(",");
                String typeAccount = p1[0];
                int numberAccount = Integer.parseInt(p1[1]);
                double amount = Double.parseDouble(p1[2]);
                if (typeAccount.equals("CC"))
                {
                    for (Payment pay : paymentObjects)
                    {
                        if (pay instanceof ConvenientCard)
                        {
                            ConvenientCard cc = (ConvenientCard) pay;
                            if (cc.getSDD() == numberAccount)
                            {
                                cc.topUp(amount);
                            }
                        }
                    }
                }
                else if (typeAccount.equals("BA"))
                {
                    for (Payment pay : paymentObjects)
                    {
                        if (pay instanceof BankAccount)
                        {
                            BankAccount bac = (BankAccount) pay;
                            if (bac.getSTK() == numberAccount)
                            {
                                bac.topUp(amount);
                            }
                        }
                    }
                }
                else 
                {
                    for (Payment pay : paymentObjects)
                    {
                        if (pay instanceof EWallet)
                        {
                            EWallet ew = (EWallet) pay;
                            if (ew.getSDT() == numberAccount)
                            {
                                ew.topUp(amount);
                            }
                        }
                    }
                }
            }
            sc1.close();
        } 
        catch (IOException exception) 
        {
            exception.printStackTrace();
        }
    }

    // Requirement 7
    public ArrayList<Bill> getUnsuccessfulTransactions(String path) 
    {
        //code here
        ArrayList<Bill> bill = new ArrayList<Bill>();
        try 
        {
            File f1 = new File(path);
            Scanner sc1 = new Scanner(f1);

            while (sc1.hasNextLine()) 
            {
                String l1 = sc1.nextLine();
                String[] p1 = l1.split(",");
                int maHoaDon = Integer.parseInt(p1[0]);
                double tien = Double.parseDouble(p1[1]);
                String mucDich = p1[2];
                String typeAccount = p1[3];
                int numberAccount = Integer.parseInt(p1[4]);
                Bill dt = new Bill(maHoaDon, tien, mucDich);
                if (typeAccount.equals("CC"))
                {
                    for (Payment paym : paymentObjects)
                    {
                        if (paym instanceof ConvenientCard)
                        {
                            ConvenientCard cc = (ConvenientCard) paym;
                            if (cc.getSDD() == numberAccount)
                            {
                                if (cc.pay(tien) == false)
                                {
                                    bill.add(dt);
                                }
                            }
                        }
                    }
                }
                else if (typeAccount.equals("EW"))
                {
                    for (Payment paym : paymentObjects)
                    {
                        if (paym instanceof EWallet)
                        {
                            EWallet ew = (EWallet) paym;
                            if (ew.getSDT() == numberAccount)
                            {
                                if (ew.pay(tien) == false)
                                {
                                    bill.add(dt);
                                }
                            }
                        }
                    }
                }
                else 
                {
                    for (Payment paym : paymentObjects)
                    {
                        if (paym instanceof BankAccount)
                        {
                            BankAccount bac = (BankAccount) paym;
                            if (bac.getSTK() == numberAccount)
                            {
                                if (bac.pay(tien) == false)
                                {
                                    bill.add(dt);
                                }
                            }
                        }
                    }
                }
            }
            sc1.close();
        } 
        catch (IOException exception) 
        {
            exception.printStackTrace();
        }
        if (bill.isEmpty()) 
        {
            return null;
        } 
        else 
        {
            return bill;
        }
    }

    // Requirement 8
    public ArrayList<BankAccount> getLargestPaymentByBA(String path) 
    {
        //code here
        ArrayList<BankAccount> tongtienmax = new ArrayList<BankAccount>();
        double paymax = 0.0;
        try 
        {
            File f1 = new File(path);
            Scanner sc1 = new Scanner(f1);
            
            while (sc1.hasNextLine()) 
            {
                String l1 = sc1.nextLine();
                String[] p1 = l1.split(",");
                int maHoaDon = Integer.parseInt(p1[0]);
                double tien = Double.parseDouble(p1[1]);
                String mucDich = p1[2];
                String typeAccount = p1[3];
                int numberAccount = Integer.parseInt(p1[4]);
                Bill dt = new Bill(maHoaDon, tien, mucDich);
                
                if (typeAccount.equals("BA")) 
                {
                    for (Payment paym : paymentObjects)
                    {
                        if (paym instanceof BankAccount)
                        {
                            BankAccount bac = (BankAccount) paym;
                            if (bac.getSTK() == numberAccount)
                            {
                                if (bac.pay(tien) == true)
                                {
                                    if (dt.getTotal() > paymax)
                                    {
                                        paymax = dt.getTotal();
                                        tongtienmax.clear();
                                        tongtienmax.add(bac);
                                    }
                                    else if (dt.getTotal() == paymax)
                                    {
                                        tongtienmax.add(bac);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            sc1.close();
        } 
        catch (IOException exception) 
        {
            exception.printStackTrace();
        }
        if (tongtienmax.isEmpty()) 
        {
            return null;
        } 
        else 
        {
            return tongtienmax;
        }
    }

    //Requirement 9
    public void processTransactionWithDiscount(String path) 
    {
        //code here
        try 
        {
            File f1 = new File(path);
            Scanner sc1 = new Scanner(f1);
            
            while (sc1.hasNextLine()) 
            {
                String l1 = sc1.nextLine();
                String[] p1 = l1.split(",");
                int maHoaDon = Integer.parseInt(p1[0]);
                double tien = Double.parseDouble(p1[1]);
                String mucDich = p1[2];
                String typeAccount = p1[3];
                int numberAccount = Integer.parseInt(p1[4]);
                if (typeAccount.equals("EW"))
                {
                    for (Payment pm1 : paymentObjects)
                    {
                        if (pm1 instanceof EWallet)
                        {
                            EWallet ew = (EWallet) pm1;
                            if (ew.getSDT() == numberAccount)
                            {
                               
                                for (Payment paym : paymentObjects)
                                {
                                    if (paym instanceof ConvenientCard)
                                    {
                                        ConvenientCard cc = (ConvenientCard) paym;
                                        if (cc.getSDT() == numberAccount)
                                        {   
                                            
                                            if (cc.getGioiTinh().equals("Female") && mucDich.equals("Clothing") && tien > 500 && cc.getNamSinh() < 18) 
                                            {
                                                ew.pay(tien * 0.85);
                                            }
                                            else if (cc.getGioiTinh().equals("Male") && mucDich.equals("Clothing") && tien > 500 && cc.getNamSinh() < 20)
                                            {
                                                ew.pay(tien * 0.85);
                                            }
                                            else
                                            {
                                                ew.pay(tien);
                                            }
                                        }
                                        
                                    }
                                }
                                int dem = 0;
                                for (Payment paym : paymentObjects)
                                {
                                    if (paym instanceof ConvenientCard)
                                    {
                                        ConvenientCard cc = (ConvenientCard) paym;
                                        if (cc.getSDT() == numberAccount)
                                        {
                                           dem = dem + 1;
                                        }
                                    }
                                }
                                if (dem == 0)
                                {
                                    ew.pay(tien);
                                }
                            }
                        }
                    }
                }
                else if (typeAccount.equals("BA"))
                {
                    for (Payment pm1 : paymentObjects)
                    {
                        if (pm1 instanceof BankAccount)
                        {
                            BankAccount bac = (BankAccount) pm1;
                            if (bac.getSTK() == numberAccount)
                            {
                                bac.pay(tien);
                            }
                        }
                    }
                }
                else if (typeAccount.equals("CC"))
                {
                    for (Payment pm1 : paymentObjects)
                    {
                        if (pm1 instanceof ConvenientCard)
                        {
                            ConvenientCard cc = (ConvenientCard) pm1;
                            if (cc.getSDD() == numberAccount)
                            {
                                cc.pay(tien);
                            }
                        }
                    }
                }            
            }
            sc1.close();
        } 
        catch (IOException exception) 
        {
            exception.printStackTrace();
        }
    }
}
