import { LoanPaymentData } from "./loan-payment-data";
import { LoanUserData } from "./loan-user-data";

export interface LoanData {
  LoanUser: LoanUserData;
  LoanSimulation: LoanPaymentData[];
}
