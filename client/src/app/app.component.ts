<<<<<<< HEAD
import { Component } from '@angular/core';
=======
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
>>>>>>> ba103ccfbd668ce144f9eb678dae01cfb8c70434

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
<<<<<<< HEAD
export class AppComponent {
  title = 'client';
=======
export class AppComponent implements OnInit {

  title : string = 'PhoneBook';
  contactsData: Object = [];

  constructor(private http: HttpClient) {
    
  }

  ngOnInit(): void {
   this.http.get('https://localhost:7242/api/Contact/GetAll').subscribe({
    next: response => this.contactsData = response,
    error: error => console.log(error),
    complete: () => console.log('Request has completed'),
  
   }) 

  }
>>>>>>> ba103ccfbd668ce144f9eb678dae01cfb8c70434
}
