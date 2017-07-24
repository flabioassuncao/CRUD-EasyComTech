import { Component, OnInit } from '@angular/core';
import { ProgrammersService } from "./programmers.service";

@Component({
  selector: 'app-programmers',
  templateUrl: './programmers.component.html'
})
export class ProgrammersComponent implements OnInit {

  programmers: any[]
  constructor(private programmerService: ProgrammersService) { }

  ngOnInit() {
    this.programmerService.programmers().subscribe(programmers => this.programmers = programmers);
  }

}
