import { Component, AfterViewInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { Helpers } from '../helpers/helpers';
import { startWith, delay } from 'rxjs/operators';

export interface Tile {
  color: string;
  cols: number;
  rows: number;
  text: string;
}


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements AfterViewInit {
  title = 'app';
  subscription: Subscription;
  authentication:boolean;
  constructor(private helpers: Helpers) { }

  tiles: Tile[] = [
    { text: 'One', cols: 3, rows: 1, color: 'lightblue' },
    { text: 'Two', cols: 1, rows: 2, color: 'lightgreen' },
    { text: '<app-nav-menu></app-nav-menu>', cols: 1, rows: 1, color: 'lightpink' },
    { text: 'Four', cols: 2, rows: 1, color: '#DDBDF1' },
  ];
  
  ngAfterViewInit(){
    this.subscription = this.helpers.isAuthenticatedChanged().pipe(
      startWith(this.helpers.isAuthenticated()),
      delay(0)).subscribe((value) => this.authentication = value);
    
  }

  ngOnDestroy(){
    this.subscription.unsubscribe();
  }

}
