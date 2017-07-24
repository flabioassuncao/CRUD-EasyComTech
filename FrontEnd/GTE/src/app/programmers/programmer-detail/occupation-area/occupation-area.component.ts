import { Component, OnInit } from '@angular/core';
import { ProgrammersService } from "../../programmers.service";
import { ActivatedRoute } from "@angular/router";
import { Observable } from "rxjs/Observable";

@Component({
  selector: 'app-occupation-area',
  templateUrl: './occupation-area.component.html'
})
export class OccupationAreaComponent implements OnInit {

  occupationArea: Observable<any>

  constructor(private programmerService: ProgrammersService,
              private route: ActivatedRoute) { }

  ngOnInit() {
    // this.occupationArea = 
    //       this.programmerService.occupationArea(this.route.parent.snapshot.params['id'])

    this.programmerService.occupationArea(this.route.parent.snapshot.params['id']).subscribe(occupation => this.occupationArea = occupation)
  }

}
