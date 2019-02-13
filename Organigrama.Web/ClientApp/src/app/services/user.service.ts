import { Injectable } from '@angular/core'
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import 'rxjs/observable/of';
import { catchError, map, tap } from 'rxjs/operators';
import { BaseService } from './base.service';
import { User } from '../models/user';
import { AppConfig } from '../config/config';
import { Helpers } from '../helpers/helpers';

@Injectable()

export class UserService extends BaseService {
    private pathWeb = this.config.setting['PathWeb'];

    constructor(private http: HttpClient, private config: AppConfig, helper: Helpers) { super(helper); }

    getUsers(): Observable<User[]> {
        return this.http.get<User[]>(this.pathWeb + 'user', super.header()).pipe(
            catchError(super.handleError)
        ); 
    }
}