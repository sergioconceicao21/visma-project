import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { LoanData } from '../../shared/loan-data';
import { LoanPaymentData } from '../../shared/loan-payment-data';
import { LoanUserData } from '../../shared/loan-user-data';

@Component({
  selector: 'app-housing-loan',
  templateUrl: './housing-loan.component.html',
  styleUrls: ['./housing-loan.component.css']
})
export class HousingLoanComponent implements OnInit {

  interestRate: number;
  loanData: LoanData;
  http: HttpClient;
  baseUrl: string;
  displayedColumns = ['Period', 'Remaining', 'Interest', 'Capital', 'Residual'];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string)
  {
    this.http = http;
    this.baseUrl = baseUrl;
    this.interestRate = 0.035;
    this.loanData = {
      LoanUser: {
        BorrowedPrincipal: 100000,
        Years: 30
      },
      LoanSimulation: []
    };

    http.get<number>(baseUrl + 'weatherforecast').subscribe((result: number) => {
      this.interestRate = result;
    }, error => console.error(error));
  }

  public Simulate_Credit() {
    this.http.post<LoanData>(this.baseUrl + 'weatherforecast', this.loanData).subscribe((result: LoanData) => {
      if (result == null) {
        this.loanData.LoanSimulation = [];
      }
      else {
        this.loanData.LoanSimulation = result.LoanSimulation;
      }
    },
      error => console.error(error));
  }

  ngOnInit(): void {
  }

}
