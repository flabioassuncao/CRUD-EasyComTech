import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';
import { RouterModule } from "@angular/router";
import { ROUTES } from "./app.routes";
import { ProgrammersComponent } from './programmers/programmers.component';
import { ProgrammerDetailComponent } from "./programmers/programmer-detail/programmer-detail.component";
import { ProgrammerComponent } from "./programmers/programmer/programmer.component";
import { OccupationAreaComponent } from "./programmers/programmer-detail/occupation-area/occupation-area.component";
import { BankInformationComponent } from "./programmers/programmer-detail/bank-information/bank-information.component";
import { KnowledgeComponent } from "./programmers/programmer-detail/knowledge/knowledge.component";
import { RegisterComponent } from './register/register.component';
import { ProgrammersService } from "./programmers/programmers.service";



@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    ProgrammersComponent,
    ProgrammerDetailComponent,
    ProgrammerComponent,
    OccupationAreaComponent,
    BankInformationComponent,
    KnowledgeComponent,
    RegisterComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    RouterModule.forRoot(ROUTES)
  ],
  providers: [ProgrammersService],
  bootstrap: [AppComponent]
})
export class AppModule { }
