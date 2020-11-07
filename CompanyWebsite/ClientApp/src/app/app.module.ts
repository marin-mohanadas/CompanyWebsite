import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { FooterComponent } from './footer/footer.component';

import { HomeComponent } from './home/home.component';
import { PartnersComponent } from './fetch-partners/fetch-partners.component';
import { ServicesComponent } from './services/services.component';
import { SinglePartnerComponent } from './single-partner/single-partner.component';


import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { PartnerService } from './_services/partner.service';



@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    FooterComponent,
    HomeComponent,
    ServicesComponent,
    PartnersComponent,
    SinglePartnerComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    BrowserAnimationsModule
  ],
  providers: [PartnerService],
  bootstrap: [AppComponent]
})
export class AppModule { }
