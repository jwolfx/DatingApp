import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  
  private readonly baseUrl = 'http://localhost:5000/api/auth/';

  constructor(private http: HttpClient) {}

  private getUrl(path: string): string{
    return this.baseUrl + path;
  }

  login(model: any): Observable<any> {
    return this.http.post(this.getUrl('login'), model).pipe(
      map((response: any) => {
        const user = response;
        if (user) {
          localStorage.setItem('token', user.token);
        }
      })
    );
  }

  /**
   * Service for register users in Dating API.
   * @param model parameter for username & password.
   */
  register(model: any): Observable<any> {
    return this.http.post(this.getUrl('register'), model);
  }
}
