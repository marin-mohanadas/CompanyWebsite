import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';



@Injectable()
export class PartnerService {
  private apiUrl: string = 'https://localhost:5001/partners/';

  constructor(private httpClient: HttpClient) { }

  public getAllPartners() {
    return this.httpClient.get(this.apiUrl);
  }

  public getSinglePartner(id: number) {
    var paramUrl = this.apiUrl + id;
    console.log(paramUrl);
    return this.httpClient.get(paramUrl);
  }

}

