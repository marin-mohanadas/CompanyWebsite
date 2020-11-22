import { Component, OnInit } from '@angular/core';
import { NewsService } from '../_services/news.service';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.css']
})
export class NewsComponent implements OnInit {
  news;

  constructor(
    private newsService: NewsService,
  ) { }

  ngOnInit() {
    this.loadAllNews();
  }

  loadAllNews() {
    this.news = this.newsService.getAllNews();
  }


}
