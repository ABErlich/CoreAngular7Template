import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Helpers } from '../../helpers/helpers';

@Component({
    selector: 'app-dashboard',
    templateUrl: './dashboard.component.html',
    styleUrls: [ './dashboard.component.css' ]
})

export class DashboardComponent implements OnInit {
    constructor(private helpers: Helpers, private router: Router){}

    ngOnInit(){
        var asd = 123;
    }

    
}