import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NewsModel } from '../_models/newsModel';

@Injectable()
export class NewsService {

  constructor(
    private httpClient: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) { }

  public getAllNews() {
    return this.httpClient.get<NewsModel[]>(`${this.baseUrl}api/news`);
  }

  public getThisNews(newsId: string) {
    return this.httpClient.get<NewsModel>(`${this.baseUrl}api/news/${newsId}`);
  }

}
