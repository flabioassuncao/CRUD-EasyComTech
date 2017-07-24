import { Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { ProgrammersComponent } from "./programmers/programmers.component";
import { ProgrammerDetailComponent } from "./programmers/programmer-detail/programmer-detail.component";
import { OccupationAreaComponent } from "./programmers/programmer-detail/occupation-area/occupation-area.component";
import { BankInformationComponent } from "./programmers/programmer-detail/bank-information/bank-information.component";
import { KnowledgeComponent } from "./programmers/programmer-detail/knowledge/knowledge.component";
import { RegisterComponent } from "./register/register.component";

export const ROUTES: Routes = [
    {path:'', component: HomeComponent},
    {path:'register', component: RegisterComponent},
    {path:'programmers', component: ProgrammersComponent},
    {path:'programmers/:id', component: ProgrammerDetailComponent,
    children: [
        {path:'', redirectTo: 'occupation-area', pathMatch: 'full'},
        {path:'occupation-area', component: OccupationAreaComponent},
        {path:'bank-information', component: BankInformationComponent},
        {path:'knowledge', component: KnowledgeComponent}
    ]}

]