import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';

import { User } from 'src/app/shared/models/user';
import { NgForm } from '@angular/forms';


@Component({
  selector: 'app-update-user',
  templateUrl: './update-user.component.html',
  styleUrls: ['./update-user.component.css']
})


export class UpdateUserComponent implements OnInit {

  user: User = {
    id: 0,
    email: '',
    fullname: '',
    joinedOn: '',
    password:''
  }


  constructor(private userService: UserService, private router: Router, private currentRoute: ActivatedRoute) { }

  ngOnInit(): void {

  }

  updateUser() {
    let id
    this.currentRoute.url.subscribe(u => id = u[2].path)
    id = Number(id)
    this.user.id = id
    this.userService.updateUser(this.user).subscribe(u => {
      if (u) {
        this.router.navigate(['/user/' + this.user.id])
      }
    })
  }

}