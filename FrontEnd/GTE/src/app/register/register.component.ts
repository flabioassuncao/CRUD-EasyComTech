import { Component, OnInit, ViewChildren, ElementRef, ViewContainerRef, AfterViewInit } from '@angular/core';
import { FormGroup, FormControlName, FormBuilder, Validators } from '@angular/forms';
import { GenericValidator } from "../utils/generic-form-validator";
import { Observable } from "rxjs/Observable";
import 'rxjs/add/observable/fromEvent';
import 'rxjs/add/observable/merge';
import 'rxjs/add/operator/debounceTime';
import { ProgrammersService } from "../programmers/programmers.service";
import { Programmer } from "../models/programmer";



@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit, AfterViewInit {
  
  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[];
  
  willingnessToWorkId: any;

  accountType: any[]
  bestTimeToWork: any[]
  willingnessToWork: any[]

  public errors: any[] = [];
  emailForm: FormGroup;
  occupationAreaForm: FormGroup;
  bankInformattionForm: FormGroup;
  knowledgeForm: FormGroup;

  programmer: any;
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
              private programmerService: ProgrammersService) { 

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
      salaryrequirements: { required: 'pretensão salarial por hora é requerido.'},
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
      email: ['', [Validators.required, Validators.email]]
    });

    this.occupationAreaForm = this.fb.group({
      name: ['', [Validators.required, Validators.minLength(2)]],
      skype: ['', [Validators.required]],
      linkedin: [''],
      phone:['', [Validators.required]],
      city: ['', [Validators.required]],
      state: ['', [Validators.required]],
      portfolio: [''],
      salaryrequirements: ['', [Validators.required]],
      bestTimeToWorkId: ['',[Validators.required]],
      willingnessToWorkId: ['', Validators.required]
    });

    this.bankInformattionForm = this.fb.group({
      name: [''],
      cpf: [''],
      bank: [''],
      agency: [''],
      accountTypeId: [''],
      accountNumber:['']
    });

    this.knowledgeForm = this.fb.group({
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

    let programmer: Programmer

    programmer = this.emailForm.value;
    programmer.bankInformation = this.bankInformattionForm.value
    programmer.knowledge = this.knowledgeForm.value
    programmer.occupationArea = this.occupationAreaForm.value
    console.log(programmer);
    this.programmerService.saveProgrammer(programmer).map(teste => console.log(teste));

    // let programmer: any;
    //programmer.email = this.emailForm.value.email;
    // programmer.OccupationArea = this.occupationAreaForm.value;
    // programmer.BankInformation = this.bankInformattionForm.value;
    // programmer.knowledgeForm.value;

    
  }

}
