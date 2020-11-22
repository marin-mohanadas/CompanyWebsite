import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NewsService } from '../_services/news.service';
import { NewsModel } from '../_models/newsModel';

@Component({
  selector: 'app-fetch-this-news',
  templateUrl: './fetch-this-news.component.html',
  styleUrls: ['./fetch-this-news.component.css']
})
export class FetchThisNewsComponent implements OnInit {
  news: NewsModel;

  constructor(
    private newsService: NewsService,
    private route: ActivatedRoute
  ) { }


  ngOnInit() {
    this.loadThisNews();
  }


  loadThisNews() {
    this.newsService.getThisNews(
      this.route.snapshot.paramMap.get('newsId')
    ).subscribe(news => {
      this.news = news;
    });
  }



}
