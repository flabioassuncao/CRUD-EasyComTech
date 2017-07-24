import { Component, OnInit } from '@angular/core';
import { Observable } from "rxjs/Observable";
import { ProgrammersService } from "../../programmers.service";
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: 'app-bank-information',
  templateUrl: './bank-information.component.html'
})
export class BankInformationComponent implements OnInit {

  bankInformation: Observable<any>
  constructor(private programmerService: ProgrammersService,
              private route: ActivatedRoute) { }

  ngOnInit() {
    // this.bankInformation = 
    //       this.programmerService.bankInformation(this.route.parent.snapshot.params['id'])

    this.programmerService.bankInformation(this.route.parent.snapshot.params['id']).subscribe(bank => this.bankInformation = bank);
  }
}
