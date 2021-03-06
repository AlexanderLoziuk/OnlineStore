import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Category } from '../_models/category';
import { AlertifyService } from './alertify.service';
import { Product } from '../_models/Product';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

baseUrl = environment.apiUrl;

constructor(private http: HttpClient, private alertify: AlertifyService) { }

getCategories(): Observable<Category[]> {
  return this.http.get<Category[]>(this.baseUrl + 'categories');
}

getCategory(id): Observable<Product[]> {
  return this.http.get<Product[]>(this.baseUrl + 'categories/' + id);
}
getProduct(catid, prodid): Observable<Product> {
  return this.http.get<Product>(this.baseUrl + 'categories/' + catid + '/' + prodid);
}
}
