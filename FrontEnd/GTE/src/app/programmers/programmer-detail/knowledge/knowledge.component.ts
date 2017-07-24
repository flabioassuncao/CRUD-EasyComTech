import { Component, OnInit, ElementRef } from '@angular/core';
import { Observable } from "rxjs/Observable";
import { ProgrammersService } from "../../programmers.service";
import { ActivatedRoute } from "@angular/router";

declare var jQuery: any;

@Component({
  selector: 'app-knowledge',
  templateUrl: './knowledge.component.html'
})
export class KnowledgeComponent implements OnInit {

  knowledge: Observable<any>
  constructor(private _elRef: ElementRef,
              private programmerService: ProgrammersService,
              private route: ActivatedRoute) { 
  }

  ngOnInit(): void {
    // this.knowledge = 
    //       this.programmerService.knowledge(this.route.parent.snapshot.params['id'])

    this.programmerService.knowledge(this.route.parent.snapshot.params['id']).subscribe(know => this.knowledge = know)

    //iCheck for checkbox and radio inputs
    // jQuery(this._elRef.nativeElement).find('input[type="checkbox"].minimal, input[type="radio"].minimal').iCheck({
    //   checkboxClass: 'icheckbox_minimal-blue',
    //   radioClass   : 'iradio_minimal-blue'
    // })
    // //Red color scheme for iCheck
    // jQuery(this._elRef.nativeElement).find('input[type="checkbox"].minimal-red, input[type="radio"].minimal-red').iCheck({
    //   checkboxClass: 'icheckbox_minimal-red',
    //   radioClass   : 'iradio_minimal-red'
    // })
    // //Flat red color scheme for iCheck
    // jQuery(this._elRef.nativeElement).find('input[type="checkbox"].flat-red, input[type="radio"].flat-red').iCheck({
    //   checkboxClass: 'icheckbox_flat-green',
    //   radioClass   : 'iradio_flat-green'
    // })
  }

}
