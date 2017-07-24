import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-programmer',
  templateUrl: './programmer.component.html'
})
export class ProgrammerComponent implements OnInit {

   @Input() programmer: any
   
  constructor() { }

  ngOnInit() {
  }

}
