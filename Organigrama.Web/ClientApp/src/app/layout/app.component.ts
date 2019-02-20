import { Component, AfterViewInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { Helpers } from '../helpers/helpers';
import { startWith, delay } from 'rxjs/operators';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements AfterViewInit {
  subscription: Subscription;
  authentication:boolean;
  constructor(private helpers: Helpers) { }
 
  ngAfterViewInit(){
    this.subscription = this.helpers.isAuthenticatedChanged().pipe(
      startWith(this.helpers.isAuthenticated()),
      delay(0)).subscribe((value) => this.authentication = value);
    
  }

  ngOnDestroy(){
    this.subscription.unsubscribe();
  }

}
