import { Component, OnInit } from '@angular/core';
import { PartnerService } from '../_services/partner.service';
import { ActivatedRoute } from '@angular/router';
import { PartnerModel } from '../_models/partnersModel';

@Component({
  selector: 'app-single-partner',
  templateUrl: './single-partner.component.html',
  styleUrls: ['./single-partner.component.css']
})
export class SinglePartnerComponent implements OnInit {
  partner: PartnerModel;

  constructor(
    private partnerService: PartnerService,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.loadPartner();
  }

  loadPartner() {
    this.partnerService.getSinglePartner(
      this.route.snapshot.paramMap.get('userName')
    ).subscribe(partner => {
      this.partner = partner;
    });
  }

}
