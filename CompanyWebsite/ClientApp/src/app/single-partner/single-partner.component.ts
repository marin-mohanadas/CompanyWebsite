import { Component, OnInit } from '@angular/core';
import { PartnerService } from '../_services/partner.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-single-partner',
  templateUrl: './single-partner.component.html',
  styleUrls: ['./single-partner.component.css']
})
export class SinglePartnerComponent implements OnInit {
  singlePartner;

  constructor(
    private partnerService: PartnerService,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.route.params.subscribe(params => {
      const id = params['name'];
      this.partnerService
        .getSinglePartner(id)
        .subscribe(data => this.singlePartner = data);
    });
  }
}
