import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-partners',
  templateUrl: './fetch-partners.component.html',
  styleUrls: ['./fetch-partners.component.css']
})

export class PartnersComponent {
  public partners: Partners;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Partners>(baseUrl + 'partners').subscribe(result => {
      this.partners = result;
    }, error => console.error(error));
  }
}

interface Partners {
  id: number;
  name: string;
  biography: string;
}




