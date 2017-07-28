import { Injectable } from "@angular/core";
import { Http, Response, RequestOptions, Headers } from "@angular/http";
import { Observable } from "rxjs/Observable";
import 'rxjs/add/operator/map'
import 'rxjs/add/operator/catch'
import { MEAT_API } from "../app.api";
import { ErrorHandler } from "../app.ErrorHandler";
import { Programmer } from "../models/programmer";

@Injectable()
export class ProgrammersService {
    
    constructor(private http: Http) { }

    programmers(): Observable<any[]>{
        let response = this.http.get(`${MEAT_API}get-all-programmers`)
            .map(this.extractData)
            .catch(ErrorHandler.handleError)
        return response;
    }

    programmer(id: string): Observable<any>{
        let response = this.http.get(`${MEAT_API}get-programmer-by-id/${id}`)
            .map(this.extractData)
            .catch(ErrorHandler.handleError)
        return response;
    }

    deleteProgrammer(id: string): void{
        let response = this.http.delete(`${MEAT_API}delete-programmer/${id}`)
            .map(this.extractData)
            .catch(ErrorHandler.handleError)
    }

    bankInformation(id: string): Observable<any>{
        let response = this.http.get(`${MEAT_API}get-bank-information-by-id/${id}`)
            .map(this.extractData)
            .catch(ErrorHandler.handleError)
        return response;
    }

    occupationArea(id: string): Observable<any>{
        let response = this.http.get(`${MEAT_API}get-occupation-area-by-id/${id}`)
            .map(this.extractData)
            .catch(ErrorHandler.handleError)
            
        return response;
    }

    knowledge(id: string): Observable<any>{
        let response = this.http.get(`${MEAT_API}get-knowledge-by-id/${id}`)
            .map(this.extractData)
            .catch(ErrorHandler.handleError)
        return response;
    }

    AccountType(): Observable<any[]>{
        let response = this.http.get(`${MEAT_API}get-all-accout-type`)
            .map(this.extractData)
            .catch(ErrorHandler.handleError)
        return response;
    }

    bestTimeToWork(): Observable<any[]>{
        let response = this.http.get(`${MEAT_API}get-all-best-time-to-work`)
            .map(this.extractData)
            .catch(ErrorHandler.handleError)
        return response;
    }
    
    willingnessToWork(): Observable<any[]>{
        let response = this.http.get(`${MEAT_API}get-all-willingness-to-work`)
            .map(this.extractData)
            .catch(ErrorHandler.handleError)
        return response;
    }

    saveProgrammer(programmer: Programmer) : Observable<any>{
        let headers = new Headers({'Content-Type': 'application/json'});
        let options = new RequestOptions({ headers });

        let response = this.http.post(`${MEAT_API}add-programmer`, programmer, options)
            .map(this.extractData)
            .catch(ErrorHandler.handleError)
        console.log(response)
        
        return response;
    }

  protected extractData(response: Response) {
    let body = response.json();
    return body.data || {};
  }
}