import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListComponent } from './list/list/list.component';
import { AddComponent } from './add/add/add.component';
import { UpdateComponent } from './update/update/update.component';

const routes: Routes = [
  {path:'',component:ListComponent},
  {path:'add',component:AddComponent},
  {path:'update',component:UpdateComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
