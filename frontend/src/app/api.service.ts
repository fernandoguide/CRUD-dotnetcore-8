import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ClienteRequest } from './model/cliente.model';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private URL: string = 'http://localhost:5084/api/Clientes';

  constructor(private httpClient: HttpClient) { }

  enviarMensagem(body: ClienteRequest) {
    return this.httpClient.post(`${this.URL}`, body)
  }
}
