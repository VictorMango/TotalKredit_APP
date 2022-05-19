using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalKredit.Model
{

    enum LoanContributionProfile
    {
        With,
        Without
    }

    enum LoanType
    {
        f5,
        f3
    }

    internal class Loan
    {

        public LoanType LoanType { get; set; }
        public double DebtLeft { get; set; }
        public int RunTimeLeft { get; set; }
        public double YearlyContributionRate { get; set; }
        public LoanContributionProfile ContributionProfile { get; set; }
        public double CurrentYearlyInterestRate { get; set; }
        public double ExpectedYearlyRateAfterRefinancing { get; set; }

        public Loan(LoanType loanType, double debtLeft, int runTimeLeft, double yearlyContributionRate, LoanContributionProfile contributionProfile, double currentYearlyInterestRate, double expectedYearlyRateAfterRefinancing)
        {
            LoanType = loanType;
            DebtLeft = debtLeft;
            RunTimeLeft = runTimeLeft;
            YearlyContributionRate = yearlyContributionRate;
            ContributionProfile = contributionProfile;
            CurrentYearlyInterestRate = currentYearlyInterestRate;
            ExpectedYearlyRateAfterRefinancing = expectedYearlyRateAfterRefinancing;
        }

    }

    internal class LoanAfterCalculation
    {

        double currentExpensesBeforeTax;
        double currentExpensesBeforeTaxAfterRefinancing;
        double currentExpensesAfterTax;
        double currentExpensesAfterTaxAfterRefinancing;

        public LoanAfterCalculation(double currentExpensesBeforeTax, double currentExpensesBeforeTaxAfterRefinancing, double currentExpensesAfterTax, double currentExpensesAfterTaxAfterRefinancing)
        {
            this.currentExpensesBeforeTax = currentExpensesBeforeTax;
            this.currentExpensesBeforeTaxAfterRefinancing = currentExpensesBeforeTaxAfterRefinancing;
            this.currentExpensesAfterTax = currentExpensesAfterTax;
            this.currentExpensesAfterTaxAfterRefinancing = currentExpensesAfterTaxAfterRefinancing;
        }


    }

    internal class LoanCalculated
    {
        LoanAfterCalculation loanWithContribution;
        LoanAfterCalculation loanWithoutContribution;

        public LoanCalculated(LoanAfterCalculation loanWithContribution, LoanAfterCalculation loanWithoutContribution)
        {
            this.loanWithContribution = loanWithContribution;
            this.loanWithoutContribution = loanWithoutContribution;
        }

    }
}
