import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Income } from 'src/app/shared/models/income';
import { map, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class IncomeService {

  constructor(private http:HttpClient) { }

  getAllIncomes(): Observable<Income[]> {
    return this.http.get<Income[]>(`${environment.apiBaseUrl}income/all`);
  }

  addIncome(income: Income): Observable<Income> {
    return this.http.post(`${environment.apiBaseUrl}income/add`, income)
      .pipe(
        map(resp => resp as Income)
      )
  }
}
