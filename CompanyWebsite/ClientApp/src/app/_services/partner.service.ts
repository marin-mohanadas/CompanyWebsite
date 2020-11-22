import { HttpClient } from '@angular/common/http';
import { Injectable, Inject } from '@angular/core';
import { PartnerModel } from '../_models/partnersModel';

@Injectable()
export class PartnerService {

  constructor(
    private httpClient: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) { }

  public getAllPartners() {
    return this.httpClient.get<PartnerModel[]>(`${this.baseUrl}api/partners`);
  }

  public getSinglePartner(username: string) {
    return this.httpClient.get<PartnerModel>(`${this.baseUrl}api/partners/${username}`);
  }

}

