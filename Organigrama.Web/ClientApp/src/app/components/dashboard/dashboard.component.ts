import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Helpers } from '../../helpers/helpers';

export interface Tile {
  color: string;
  cols: number;
  rows: number;
  text: string;
}

@Component({
    selector: 'app-dashboard',
    templateUrl: './dashboard.component.html',
    styleUrls: [ './dashboard.component.css' ]
})

export class DashboardComponent implements OnInit {
    constructor(private helpers: Helpers, private router: Router){}
    tiles: Tile[] = [
      { text: 'One', cols: 3, rows: 1, color: 'lightblue' },
      { text: 'Two', cols: 1, rows: 2, color: 'lightgreen' },
      { text: 'Three', cols: 1, rows: 1, color: 'lightpink' },
      { text: 'Four', cols: 2, rows: 1, color: '#DDBDF1' },
    ];
    ngOnInit(){
        var asd = 123;
    }

    
}
