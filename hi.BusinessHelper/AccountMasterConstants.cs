using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hi.BusinessHelper
{
    public static class AccountMasterConstants
    {
        public static readonly string SelectCommand = "SELECT * FROM account_master";
        public static readonly string SelectWithIdCommand = "SELECT account_name,account_alias,print_name,account_group_id,branch_id,opening_credit,opening_debit,alternate_account,party_id,multi_currency_OpeningBal,is_predefined FROM account_master" +
                                                            " JOIN account_opening_balance ON account_master.account_id=account_opening_balance.account_id WHERE account_master.account_id=@account_id";
        public static readonly string OverviewSelectCommand = "SELECT * FROM account_master";  ///add necessary columns, addition joints for the overview
        public static readonly string UpdateProcedureName = "dbo.usp_AccountMasterUpdate";

        public static readonly string SelectCommandSearch = "SELECT account_master.account_id,account_name,account_alias,opening_credit,opening_debit,account_group_name,branch_name FROM account_master" +
                                                             " JOIN account_group_master ON account_master.account_group_id=account_group_master.account_group_id"+
                                                             " JOIN branch_master ON account_master.branch_id=branch_master.branch_id"+
                                                             " JOIN account_opening_balance ON account_master.account_id=account_opening_balance.account_id";
        public static readonly string SelectAccountDW = "SELECT account_id,account_name FROM account_master";

        public static readonly string SelectBillbybillDetailsWithTransactionID = "select 0 as Sid,billDate as CuDate,referenceNote as Reference," +
                                                                              " case when debit_amount>0  then 2 else 1 end as transaction_type," +
                                                                              "  billAmount as Amount,settled_date as DueDate" +
                                                                              " from bill_By_bill where account_id=@AccountID";

        public static readonly string SelectCurrencylDetailsWithAccountID = "SELECT 0 as CurrencyLineSid,currency_short_name as CurrencytypeID,"+
                                                                            " Dr_Cr as CurrencyLinetransaction_type,op_bal_foreign as Currencyopenbal,"+
                                                                            " op_bal_converted as ConvertedAmount  FROM open_bal_multiCurrency where account_id=@AccountID";
        public static readonly string SelectAccountCurrency = "dbo.get_accountcurrencydetails";
        public static readonly string SelectBillbybillAccounts = "get_billBybill_account";

        public static readonly string SelectBillByBillwithAccount = "SELECT billid,referenceNote,billAmount,case when debit_amount>0  then 'D' else 'C' end as transaction_type FROM bill_By_bill WHERE account_id=@account_id";

        public static readonly string SelectCashAccount = "select account_id,account_name from [dbo].[account_master] where account_id=7 UNION select account_id,account_name from [dbo].[account_master] where account_group_id In (9,13)";

        public static readonly string SelectSundaryAccount="select account_id,account_name from [dbo].[account_master] where account_group_id In (9,13)";

        public static readonly string SelectSupplierDetails = "SELECT * FROM [dbo].[account_master] LEFT JOIN [dbo].[party_master]"
                                                            + " ON [dbo].[account_master].party_id = [dbo].[party_master].party_id Where [dbo].[account_master].account_id=@account_id;";

        public static readonly string SelectCreditCardAccount = "Select account_id,account_name from [dbo].[account_master] where account_group_id=4";
    }  
}
