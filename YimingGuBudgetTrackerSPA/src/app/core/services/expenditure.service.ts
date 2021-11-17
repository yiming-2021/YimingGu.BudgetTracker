import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Expenditure } from 'src/app/shared/models/expenditure';
import { map, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ExpenditureService {

  constructor(private http:HttpClient) { }

  getAllExpenditures(): Observable<Expenditure[]> {
    return this.http.get<Expenditure[]>(`${environment.apiBaseUrl}expenditure/all`);
  }

  addIncome(expenditure: Expenditure): Observable<Expenditure> {
    return this.http.post(`${environment.apiBaseUrl}expenditure/add`, expenditure)
      .pipe(
        map(resp => resp as Expenditure)
      )
  }
}
