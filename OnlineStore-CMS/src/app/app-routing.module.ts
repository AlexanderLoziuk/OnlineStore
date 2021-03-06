import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BalanceComponent } from './balance/balance.component';
import { ReceiptListComponent } from './receipt-list/receipt-list.component';
import { ConsumptionListComponent } from './consumption-list/consumption-list.component';
import { CategoriesListComponent } from './categories-list/categories-list.component';
import { ProductsListComponent } from './products-list/products-list.component';
import { OrdersListComponent } from './orders-list/orders-list.component';
import { MainComponent } from './main/main.component';
import { AuthGuard } from './_guards/auth.guard';
import { CategoriesListResolver } from './_resolvers/categories-list.resolver';
import { CategoryAddComponent } from './category-add/category-add.component';
import { CategoryEditComponent } from './category-edit/category-edit.component';
import { CategoriesEditResolver } from './_resolvers/categories-edit.resolver';
import { WelcomepageComponent } from './welcomepage/welcomepage.component';
import { ProductsListResolver } from './_resolvers/products-list.resolver';
import { ProductAddComponent } from './product-add/product-add.component';
import { ColorsListReolver } from './_resolvers/colors-list.resolver';
import { ColorsListComponent } from './colors-list/colors-list.component';
import { ColorsAddComponent } from './colors-add/colors-add.component';
import { ProductEditComponent } from './product-edit/product-edit.component';
import { ProductsEditResolver } from './_resolvers/products-edit.resolver';
import { ReceiptAddComponent } from './receipt-add/receipt-add.component';
import { ReceiptListResolver } from './_resolvers/receipt-list.resolver';
import { OrdersListResolver } from './_resolvers/orders-list.resolver';
import { OrderEditComponent } from './order-edit/order-edit.component';
import { OrderDetailResolver } from './_resolvers/order-detail.resolver';
import { StringsorderComponent } from './stringsorder/stringsorder.component';



const routes: Routes = [
  {path: 'welcomepage', component: WelcomepageComponent},
  {path: 'balance', component: BalanceComponent},
  {path: 'receiptadmin', component: ReceiptListComponent, resolve:{receipts: ReceiptListResolver}},
  {path: 'receiptadmin/add', component: ReceiptAddComponent, resolve: {categories: CategoriesListResolver, products: ProductsListResolver}},
  {path: 'consumptionadmin', component: ConsumptionListComponent},
  {path: 'categoriesadmin', component: CategoriesListComponent, resolve: {categories: CategoriesListResolver}},
  {path: 'productsadmin', component: ProductsListComponent, resolve: {products: ProductsListResolver}},
  {path: 'productsadmin/add', component: ProductAddComponent, resolve: {categories: CategoriesListResolver, colors: ColorsListReolver} },
  {path: 'productsadmin/:id/edit', component: ProductEditComponent, resolve: {product: ProductsEditResolver, categories: CategoriesListResolver, colors: ColorsListReolver}},
  {path: 'orderadmin', component: OrdersListComponent, resolve: {orders: OrdersListResolver }},
  {path: 'categoriesadmin/add', component: CategoryAddComponent},
  {path: 'categoriesadmin/:id/edit', component: CategoryEditComponent, resolve: {category: CategoriesEditResolver}},
  {path: 'colors', component: ColorsListComponent, resolve: {colors: ColorsListReolver} },
  {path: 'colors/add', component: ColorsAddComponent},
  {path: 'orderadmin/:id', component: OrderEditComponent, resolve: {orderDetail: OrderDetailResolver}},
  {path: 'orderadmin/:id/stringsorderadmin', component: StringsorderComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
