import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PlayerService {

  constructor(private http: HttpClient) { }

  baseUrl = environment.apiUrl;

  getPlayers() {
    return this.http.get(this.baseUrl + '/api/Player');
  }
}
