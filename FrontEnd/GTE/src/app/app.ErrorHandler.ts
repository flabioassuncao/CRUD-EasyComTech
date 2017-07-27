import {Response} from "@angular/http"
import { Observable } from "rxjs/Observable";

export class ErrorHandler{
    static handleError(error: Response | any){
        let errorMessage: string
        if(error instanceof Response)
        {
            const body = error.json() || '';
            const err = body.errors || JSON.stringify(body);
            errorMessage = `${error.status} - ${error.statusText || ''} ${err}`;
        }else{
            errorMessage = error.message ? error.message : error.toString();
        }
        console.log(errorMessage)
        return Observable.throw (errorMessage);
        
    }
}