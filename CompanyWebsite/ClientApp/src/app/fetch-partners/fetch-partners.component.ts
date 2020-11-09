import { Component, OnInit } from '@angular/core';
import { PartnerService } from '../_services/partner.service';

@Component({
  selector: 'app-partners',
  templateUrl: './fetch-partners.component.html',
  styleUrls: ['./fetch-partners.component.css']
})

export class PartnersComponent implements OnInit {
  partners;

  constructor(private partnerService: PartnerService) { }

  ngOnInit() {
    this.loadPartners();
  }

  loadPartners() {
    this.partners = this.partnerService.getAllPartners();
  }

}
