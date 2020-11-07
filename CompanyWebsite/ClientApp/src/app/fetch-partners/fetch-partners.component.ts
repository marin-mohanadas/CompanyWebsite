import { Component, OnInit } from '@angular/core';
import { PartnerService } from '../_services/partner.service';


@Component({
  selector: 'app-partners',
  templateUrl: './fetch-partners.component.html',
  styleUrls: ['./fetch-partners.component.css']
})

export class PartnersComponent implements OnInit {
  //partners = [];
  partners;

  constructor(private partnerService: PartnerService) { }

  ngOnInit() {
    //this.partnerService.getAllPartners()
    //  .subscribe((data: any[]) => {
    //    console.log(data);
    //    this.partners = data;
    //  })

    this.partners = this.partnerService.getAllPartners();
  }


}
