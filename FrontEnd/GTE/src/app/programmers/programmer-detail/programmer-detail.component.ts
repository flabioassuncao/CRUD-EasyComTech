import { Component, OnInit } from '@angular/core';
import { ProgrammersService } from "../programmers.service";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
  selector: 'app-programmer-detail',
  templateUrl: './programmer-detail.component.html'
})
export class ProgrammerDetailComponent implements OnInit {

  programmer: any
  constructor(private programmersService: ProgrammersService, private route: ActivatedRoute,
              private router: Router) { }

  ngOnInit() {
    this.programmersService.programmer(this.route.snapshot.params['id'])
    .subscribe(program => this.programmer = program);
  }

  DeleteProgrammer(){
    this.router.navigate(['./programmers'])
  }

}
