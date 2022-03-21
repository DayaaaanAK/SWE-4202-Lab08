using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Creat_On_Click(object sender, EventArgs e)
        {
            if(Current_Button.Checked == true)
            {
                string name = Name_Input.Text;
                string id = Current_Account.account_id.ToString()+"300";
                Current_Account.account_id++;
                int deposit =Convert.ToInt32(Deposit_Input.Text);
                if (deposit < 500)
                { MessageBox.Show("Please deposit at least BDT 500"); }
                Current_Account dummy = new Current_Account(name,id,deposit);
                Bank.current_accounts.Add(dummy);
                MessageBox.Show("Account has been created. Account ID is " + id);
            }
            else if (Savings_Button.Checked == true)
            {
                string name = Name_Input.Text;
                string id = Savings_Account.account_id.ToString() + "300";
                Savings_Account.account_id++;
                int deposit = Convert.ToInt32(Deposit_Input.Text);
                if (deposit < 500)
                { MessageBox.Show("Please deposit at least BDT 50000"); }
                Savings_Account dummy = new Savings_Account(name, id, deposit);
                Bank.savings_accounts.Add(dummy);
                MessageBox.Show("Account has been created. Account ID is " + id);
            }
            else if (Loan_Button.Checked == true)
            {
                string name = Name_Input.Text;
                string id = Loan_Account.account_id.ToString() + "300";
                Loan_Account.account_id++;
                double loan = Convert.ToDouble(Loan_Input.Text);
                loan = loan * 0.9 + loan;
                Loan_Account dummy = new Loan_Account(name, id, loan);
                Bank.loan_accounts.Add(dummy);
                MessageBox.Show("Account has been created. Account ID is " + id);
            }
            
        }

        private void Deposit_OnClick(object sender, EventArgs e)
        {
            if(Current_Button_Deposit.Checked == true)
            {
                string id = Deposit_ID.Text;
                int deposit = Convert.ToInt32(Deposit_Amount.Text);
                foreach(Current_Account dummy in Bank.current_accounts)
                {
                    if (deposit > Current_Account.max_transaction)
                        MessageBox.Show("Cannot deposit amount more than BDT " + Current_Account.max_transaction);
                    else if (id == dummy.id)
                    {
                        dummy.balance+=deposit;
                    }
                }
            }
            else if (Savings_Button_Deposit.Checked == true)
            {
                string id = Deposit_ID.Text;
                int deposit = Convert.ToInt32(Deposit_Amount.Text);
                foreach (Savings_Account dummy in Bank.savings_accounts)
                {
                    if (id == dummy.id)
                    {
                        dummy.balance += deposit;
                    }
                }
            }
            else if (Loan_Button_Deposit.Checked == true)
            {
                string id = Deposit_ID.Text;
                int deposit = Convert.ToInt32(Deposit_Amount.Text);
                foreach (Loan_Account dummy in Bank.loan_accounts)
                {
                    if (id == dummy.id)
                    {
                        dummy.balance += deposit;
                    }
                }
            }
        }

        private void Withdraw_OnClick(object sender, EventArgs e)
        {
            if (Current_Button_Withdraw.Checked == true)
            {
                string id = Deposit_ID.Text;
                int deposit = Convert.ToInt32(Deposit_Amount.Text);
                foreach (Current_Account dummy in Bank.current_accounts)
                {
                    if (deposit > Current_Account.max_transaction)
                        MessageBox.Show("Cannot deposit amount more than BDT " + Current_Account.max_transaction);
                    else if(id == dummy.id)
                    {
                        int check = dummy.balance;
                        check -= deposit;
                        if (check < 500)
                            MessageBox.Show("Balance cannot go below BDT 500");
                        else dummy.balance -= deposit;
                    }
                }
            }
            else if (Savings_Button_Withdraw.Checked == true)
            {
                string id = Deposit_ID.Text;
                int deposit = Convert.ToInt32(Deposit_Amount.Text);
                foreach (Savings_Account dummy in Bank.savings_accounts)
                {
                    if (id == dummy.id)
                    {
                        dummy.balance -= deposit;
                    }
                }
            }
        }

        private void ShowInfo_OnClick(object sender, EventArgs e)
        {
            if (Current_Info.Checked == true)
            {
                string id = Info_ID.Text;
                foreach(Current_Account dummy in Bank.current_accounts)
                {
                    if(dummy.id == id)
                    {
                        Info_Name_Output.Text = dummy.name;
                        Info_Balance_Output.Text = "BDT " + dummy.balance.ToString();
                    }
                }
            }
            else if (Savings_Info.Checked == true)
            {
                string id = Info_ID.Text;
                foreach (Savings_Account dummy in Bank.savings_accounts)
                {
                    if (dummy.id == id)
                    {
                        Info_Name_Output.Text = dummy.name;
                        Info_Balance_Output.Text = "BDT " + dummy.balance.ToString();
                    }
                }
            }
            else if (Loan_Info.Checked == true)
            {
                string id = Info_ID.Text;
                foreach (Loan_Account dummy in Bank.loan_accounts)
                {
                    if (dummy.id == id)
                    {
                        Info_Name_Output.Text = dummy.name;
                        Info_Balance_Output.Text ="BDT " + dummy.loan.ToString();
                    }
                }
            }
        }
    }
}
