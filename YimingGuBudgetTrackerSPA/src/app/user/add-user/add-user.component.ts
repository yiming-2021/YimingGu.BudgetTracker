import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';
import { User } from 'src/app/shared/models/user';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})

export class AddUserComponent implements OnInit {

  user: User = {
    id: 0,
    email: '',
    fullname: '',
    joinedOn: '',
    password:''
  }

  submitted = false;

  constructor(private userService: UserService, private router: Router) { }

  ngOnInit(): void {
  }

  addUser(): void {
    const data = {
      id: this.user.id,
      email: this.user.email,
      fullname: this.user.fullname,
      joinedOn: this.user.joinedOn,
      password: this.user.password
    };



    this.userService.addUser(data).subscribe(
      response => {
        console.log(response);
        this.submitted = true;
      });
}

  newUser(): void {
    this.submitted = false;
    this.user = {
      id: 0,
      email: '',
      fullname: '',
      joinedOn: '',
      password:''
    };
}

}





