import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { PartnersComponent } from './fetch-partners/fetch-partners.component';
import { ServicesComponent } from './services/services.component';
import { SinglePartnerComponent } from './single-partner/single-partner.component';
import { NewsComponent } from './news/news.component';
import { FetchThisNewsComponent } from './fetch-this-news/fetch-this-news.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent,
    pathMatch: 'full'
  },
  {
    path: 'services',
    component: ServicesComponent
  },
  {
    path: 'bio',
    component: PartnersComponent
  },
  {
    path: 'bio/:userName',
    component: SinglePartnerComponent
  },
  {
    path: 'news',
    component: NewsComponent
  },
  {
    path: 'news/:newsId',
    component: FetchThisNewsComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
