import { Injectable } from "@angular/core";
import { Http, Response } from "@angular/http";
import { Observable } from "rxjs/Observable";
import 'rxjs/add/operator/map'
import 'rxjs/add/operator/catch'
import { MEAT_API } from "../app.api";
import { ErrorHandler } from "../app.ErrorHandler";

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
        let response = this.http.get(`${MEAT_API}delete-programmer/${id}`)
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

  protected extractData(response: Response) {
    let body = response.json();
    return body.data || {};
  }
}