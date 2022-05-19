using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalKredit.Model;

namespace TotalKredit.Controller
{
    internal class LoanController
    {

        private double f5CurrentInterestOfRateWithoutContribution = 1;
        private double f5CurrentInterestOfRateWithContribution = 0.76;
        private double f5RefinancingInterestOfRateWithoutContribution = 1;
        private double f5RefinancingInterestOfRateWithContribution = 0.76;

        private double currentF3InterestOfRateWithoutContribution = 1.20;
        private double currentF3InterestOfRateWithContribution = 0.96;
        private double f3InterestOfRateWithoutContribution = 1.20;
        private double f3InterestOfRateWithContribution = 0.96;

        public LoanCalculated CalculateLoan(Loan currentLoan)
        {

            double currentInterestRateBeforeTax;
            double currentInterestRateBeforeTaxAfterRefinancing;
            double currentInterestRateAfterTax;
            double currentInterestRateAfterTaxAfterRefinancing;

            switch (currentLoan.ContributionProfile)
            {
                case LoanContributionProfile.With:
                    currentInterestRateBeforeTax = getContributionRate(currentLoan.RunTimeLeft, currentLoan.LoanType == LoanType.f5 ? f5CurrentInterestOfRateWithContribution : currentF3InterestOfRateWithContribution, currentLoan.DebtLeft);
                    currentInterestRateBeforeTaxAfterRefinancing = getContributionRate(currentLoan.RunTimeLeft, currentLoan.LoanType == LoanType.f5 = f5RefinancingInterestOfRateWithContribution : f3, currentLoan.DebtLeft);
                    
                    break;

                case LoanContributionProfile.Without:

                    break;
            }


        }

        private double getContributionRate(double numberOfContributions, double rateOfInterest, double currentLoanSize)
        {
            return currentLoanSize * rateOfInterest / Math.Pow(1 - (1 + rateOfInterest), -numberOfContributions);
        }

    }
}
