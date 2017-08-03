import { Component, OnInit, ViewChildren, ElementRef, ViewContainerRef, AfterViewInit } from '@angular/core';
import { FormGroup, FormControlName, FormBuilder, Validators } from '@angular/forms';
import { GenericValidator } from "../utils/generic-form-validator";
import { Observable } from "rxjs/Observable";
import 'rxjs/add/observable/fromEvent';
import 'rxjs/add/observable/merge';
import 'rxjs/add/operator/debounceTime';
import { ProgrammersService } from "../programmers/programmers.service";
import { Programmer } from "../models/programmer";
import { knowledge } from "../models/knowledge";
import { OccupationArea } from "../models/occupationArea";
import { BankInformation } from "../models/bankInformation";
import { ActivatedRoute, Router } from "@angular/router";



@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit, AfterViewInit {
  
  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[];
  
  isUpdate: boolean = false;

  ProgrammerEdit: any
  programmer: Programmer
  occupationArea: OccupationArea
  bankInformation: BankInformation
  knowledge: knowledge

  accountType: any[]
  bestTimeToWork: any[]
  willingnessToWork: any[]

  public errors: any[] = [];
  emailForm: FormGroup;
  occupationAreaForm: FormGroup;
  bankInformattionForm: FormGroup;
  knowledgeForm: FormGroup;

  displayMessageEmail: { [key: string]: string } = {};
  displayMessageOccupationArea: { [key: string]: string } = {};
  displayMessageBankInformation: { [key: string]: string } = {};
  displayMessageKnowledge: { [key: string]: string } = {};

  private validationMessagesEmail: {[key: string]: { [key: string]: string}};
  private validationMessagesOccupationArea: {[key: string]: { [key: string]: string}};
  private validationMessagesBankInformation: {[key: string]: { [key: string]: string}};
  private validationMessagesKnowledge: {[key: string]: { [key: string]: string}};

  genericValidator: GenericValidator;
  genericValidatorOccupationArea: GenericValidator;
  genericValidatorBankInformation: GenericValidator;
  genericValidatorKnowledge: GenericValidator;

  constructor(private fb: FormBuilder,
              vcr: ViewContainerRef,
              private programmerService: ProgrammersService,
              private route: ActivatedRoute,
              private router: Router) { 

    this.validationMessagesEmail = {
      email: {
        required: 'informe o Email',
        email: 'email invalido'
      }
    };

    this.validationMessagesOccupationArea = {
      name: {
        required: 'O nome é requerido.',
        minlength: 'O nome precisa ter no minimo 2 caracteres'
      },
      skype: { required: 'skype é requerido.'},
      phone: { required: 'Telefone é requerido.'},
      city:{ required: 'Cidade é requerido.'},
      state:{ required: 'Estado é requerido.'},
      HourlySalaryRequirements: { required: 'pretensão salarial por hora é requerido.'},
      willingnessToWorkId: { required: 'selecione uma opção'},
      bestTimeToWorkId: { required: 'selecione uma opção'}
    };

    this.validationMessagesBankInformation = {
      //não requeridos....
    };

    this.validationMessagesKnowledge = {
      levelOfKnowledgeIonic: { required: 'selecione uma opção' },
      levelOfKnowledgeAndroid: { required: 'selecione uma opção' },
      levelOfKnowledgeIOS: { required: 'selecione uma opção' },
      levelOfKnowledgeBootstrap: { required: 'selecione uma opção' },
      levelOfKnowledgeJquery: { required: 'selecione uma opção' },
      levelOfKnowledgeAngularJs: { required: 'selecione uma opção' },
      levelOfKnowledgeAspNetMVC: { required: 'selecione uma opção' },
      levelOfKnowledgePHP: { required: 'selecione uma opção' },
      levelOfKnowledgeWordpress: { required: 'selecione uma opção' }
    }

    this.genericValidator = new GenericValidator(this.validationMessagesEmail);
    this.genericValidatorOccupationArea = new GenericValidator(this.validationMessagesOccupationArea);
    this.genericValidatorBankInformation = new GenericValidator(this.validationMessagesBankInformation);
    this.genericValidatorKnowledge = new GenericValidator(this.validationMessagesKnowledge);
  }

  ngOnInit() {
    this.programmerService.AccountType().subscribe(accounts => this.accountType = accounts);
    this.programmerService.bestTimeToWork().subscribe(bestTimes => this.bestTimeToWork = bestTimes);
    this.programmerService.willingnessToWork().subscribe(will => this.willingnessToWork = will);


    this.emailForm = this.fb.group({
      id: [''],
      excluded: [''],
      occupationAreaId: [''],
      occupationArea: [''],
      bankInformationId :[''],
      bankInformation: [''],
      knowledgeId: [''],
      knowledge:[''],

      email: ['', [Validators.required, Validators.email]]
    });

    this.occupationAreaForm = this.fb.group({
      id: [''],
      willingnessToWork: [''],
      bestTimeToWork: [''],
      programmerId: [''],
      programmer: [''],

      name: ['', [Validators.required, Validators.minLength(2)]],
      skype: ['', [Validators.required]],
      linkedin: [''],
      phone:['', [Validators.required]],
      city: ['', [Validators.required]],
      state: ['', [Validators.required]],
      portfolio: [''],
      hourlySalaryRequirements: [null, [Validators.required, Validators.max(1000)]],
      bestTimeToWorkId: ['',[Validators.required]],
      willingnessToWorkId: ['', Validators.required]
    });

    this.bankInformattionForm = this.fb.group({
      id: [''],
      accountType: [''],
      programmerId: [''],
      programmer: [''],

      name: [''],
      cpf: [''],
      bank: [''],
      agency: [''],
      accountTypeId: [''],
      accountNumber:['']
    });

    this.knowledgeForm = this.fb.group({
      id: [''],
      programmerId: [''],
      programmer: [''],


      levelOfKnowledgeIonic: ['', [Validators.required]],
      levelOfKnowledgeAndroid: ['', [Validators.required]],
      levelOfKnowledgeIOS: ['', [Validators.required]],
      levelOfKnowledgeHTML: [''],
      levelOfKnowledgeCSS: [''],
      levelOfKnowledgeBootstrap: ['', [Validators.required]],
      levelOfKnowledgeJquery: ['', [Validators.required]],
      levelOfKnowledgeAngularJs: ['', [Validators.required]],
      levelOfKnowledgeJava: [''],
      levelOfKnowledgeAspNetMVC: ['', [Validators.required]],
      levelOfKnowledgeC: [''],
      levelOfKnowledgeCPlusPlus: [''],
      levelOfKnowledgeCake: [''],
      levelOfKnowledgeDjango: [''],
      levelOfKnowledgeMajento: [''],
      levelOfKnowledgePHP: ['', [Validators.required]],
      levelOfKnowledgeWordpress: ['', [Validators.required]],
      levelOfKnowledgePhyton: [''],
      levelOfKnowledgeRuby: [''],
      levelOfKnowledgeMySQLServer: [''],
      levelOfKnowledgeMySQL: [''],
      levelOfKnowledgeSalesforce: [''],
      levelOfKnowledgePhotoshop: [''],
      levelOfKnowledgeIllustrator: [''],
      levelOfKnowledgeSEO: [''],
      otherLanguageOrFramework: [''],
      linkCRUD: ['']
    });


    if(this.route.snapshot.params['id'] === undefined){
      // console.log("true")
    }else{
      this.isUpdate = true;
      this.programmerService.programmer(this.route.snapshot.params['id'])
          .subscribe(program => this.completeForms(program));
    }
  }

  completeForms(programmer: any)
  {
    this.emailForm.setValue(programmer);
    this.occupationAreaForm.setValue(programmer.occupationArea);
    this.bankInformattionForm.setValue(programmer.bankInformation)
    this.knowledgeForm.setValue(programmer.knowledge);
  }

  ngAfterViewInit(): void {
    let controlBlurs: Observable<any>[] = this.formInputElements
    .map((formControl: ElementRef) => Observable.fromEvent(formControl.nativeElement, 'blur'));
    
    Observable.merge(this.emailForm.valueChanges, ...controlBlurs).debounceTime(100).subscribe(value => {
      this.displayMessageEmail = this.genericValidator.processMessages(this.emailForm);
    });

    Observable.merge(this.occupationAreaForm.valueChanges, ...controlBlurs).debounceTime(100).subscribe(value => {
      this.displayMessageOccupationArea = this.genericValidatorOccupationArea.processMessages(this.occupationAreaForm);
    });

    Observable.merge(this.bankInformattionForm.valueChanges, ...controlBlurs).debounceTime(100).subscribe(value => {
      this.displayMessageBankInformation = this.genericValidatorBankInformation.processMessages(this.bankInformattionForm);
    });

    Observable.merge(this.knowledgeForm.valueChanges, ...controlBlurs).debounceTime(100).subscribe(value => {
      this.displayMessageKnowledge = this.genericValidatorKnowledge.processMessages(this.knowledgeForm);
    });
  }


  saveProgrammer(){
    
    this.programmer = Object.assign({}, this.emailForm.value);
    this.programmer.bankInformation = Object.assign({}, this.bankInformattionForm.value)
    this.programmer.knowledge = Object.assign({}, this.knowledgeForm.value)
    this.programmer.occupationArea =  Object.assign({}, this.occupationAreaForm.value)

    if(this.isUpdate){
      this.programmerService.updateProgrammer(this.programmer)
      .subscribe(
        result => {this.onSaveComplete(result)},
        error => {this.onSaveError(error)}
      );
    }
    else{
      delete this.programmer['id'];
      delete this.programmer['excluded'];
      delete this.programmer['occupationAreaId'];
      delete this.programmer['bankInformationId'];
      delete this.programmer['knowledgeId'];

      delete this.programmer.occupationArea['id'];
      delete this.programmer.occupationArea['willingnessToWork'];
      delete this.programmer.occupationArea['bestTimeToWork'];
      delete this.programmer.occupationArea['programmerId'];
      delete this.programmer.occupationArea['programmer'];

      delete this.programmer.bankInformation['id'];
      delete this.programmer.bankInformation['accountType'];
      delete this.programmer.bankInformation['programmerId'];
      delete this.programmer.bankInformation['programmer'];

      delete this.programmer.knowledge['id'];
      delete this.programmer.knowledge['programmerId'];
      delete this.programmer.knowledge['programmer'];

      this.programmerService.saveProgrammer(this.programmer)
      .subscribe(
        result => {this.onSaveComplete(result)},
        error => {this.onSaveError(error)}
      );
    }
    
  }

  onSaveError(error: any){
    this.errors = JSON.parse(error._body).errors;
    console.log(this.errors);
  }

  onSaveComplete(response: any) {
    this.errors = [];
    this.router.navigate(['./programmers'])
  }

}
