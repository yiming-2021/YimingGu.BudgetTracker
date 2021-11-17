import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Expenditure } from 'src/app/shared/models/expenditure';
import { Income } from 'src/app/shared/models/income';
import { User } from 'src/app/shared/models/user';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http:HttpClient) { }

  getAllUsers(): Observable<User[]> {
    return this.http.get<User[]>(`${environment.apiBaseUrl}user/all`);
  }


  getUserById(id: number):Observable<User>{
    return this.http.get<User>(`${environment.apiBaseUrl}user/${id}`);
  }

  deleteUser(id: number): Observable<User> {
    return this.http.delete(`${environment.apiBaseUrl}user/${id}`)
      .pipe(
        map(resp => resp as User)
      )
  }

  addUser(user: User): Observable<User> {
    return this.http.post(`${environment.apiBaseUrl}user`, user)
      .pipe(
        map(resp => resp as User)
      )
  }

  updateUser(user: User): Observable<User> {
    return this.http.put(`${environment.apiBaseUrl}user`, user)
      .pipe(
        map(resp => resp as User)
      )
  }

  getUserIncomeById(id: number):Observable<Income[]>{
    return this.http.get<Income[]>(`${environment.apiBaseUrl}user/income/${id}`);
  }

  getUserExpById(id: number):Observable<Expenditure[]>{
    return this.http.get<Expenditure[]>(`${environment.apiBaseUrl}user/expenditure/${id}`);
  }


}