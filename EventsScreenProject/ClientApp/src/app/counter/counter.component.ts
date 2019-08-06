import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public events: any[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    var Inject = function(url: string) { throw new Error("Not implemented"); };
    http.get<any[]>(baseUrl + 'api/events').subscribe(result => {
      this.events = result;
      console.log(this.events);
    }, error => console.error(error));
  }


}

interface WeatherForecast {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

