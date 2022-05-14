



import { Payment } from '../../shared/modules/Payment.module';

import { PageMenu } from '../../shared/modules/PageMenu.module';

import { VisitedHistory } from '../../shared/modules/VisitedHistory.module';

import { PageGenerator } from '../../shared/modules/PageGenerator.module';




import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

import { User } from '../../shared/modules/User';
import { UserRole } from '../../shared/modules/UserRole.module';
import { Router } from '@angular/router';
import { them } from '../service/themplate.service';
import { DenyMenu } from '../../shared/modules/UserAccess.module';
import { Menu } from '../../shared/modules/UserAccess.module';

import { CompanySettings } from '../../shared/modules/CompanySettings.module';
import { MenuView } from '../../shared/modules/PageMenu.module';
@Injectable()
export class ConfigService {

  configUrlBasic = this.them.configUrlBasic;
  public loading = false;
  configUrl: string = "";

  constructor(private http: HttpClient, public router: Router, public them: them) { }

  handleError(error: HttpErrorResponse) {
    let msg = '';
    if (error.error instanceof ErrorEvent) {
      // client-side error
      msg = error.error.message;
    } else {
      // server-side error

      msg = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(msg);
  }

  //*****************FileUploader************************
  FileUploader(formData: any) {
    this.configUrl = this.configUrlBasic + '/Uploader/Post'
    return this.http.post<String>(this.configUrl, formData).pipe(
      catchError(this.handleError)
    );
  }




  //UserProfile*********************************************************************
  FetchUserProfile_Filter(Lang: string, UserName: string) {
    this.configUrl = this.configUrlBasic + '/UserProfile/Get'

    return this.http.get<User[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName
      }

    }).pipe(
      catchError(this.handleError)
    );
  }
  FetchUserProfile_FilterID(Lang: string, UserName: string, ID: string) {
    this.configUrl = this.configUrlBasic + '/UserProfile/Get'

    return this.http.get<User[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        ID: ID
      }

    }).pipe(
      catchError(this.handleError)
    );
  }
  FetchUserProfile_FilterDefaultCompany(Lang: string, UserName: string) {
    this.configUrl = this.configUrlBasic + '/UserProfile/Get'

    return this.http.get<User[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        isDefault: 'true'
      }

    }).pipe(
      catchError(this.handleError)
    );
  }
  Fetch_FilterUserProfileGet(Lang: string, UserName: string, UserID: string, Name: string, Family: string, CompanyID: string, RoleID: string, Mobile: string, TokenID: string, Email: string, NationalCode: string) {
    this.configUrl = this.configUrlBasic + '/UserProfile/Get'

    return this.http.get<User[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        UserID: UserID,
        Name: Name,
        Family: Family,
        CompanyID: CompanyID,
        RoleID: RoleID,
        Mobile: Mobile,
        TokenID: TokenID,
        Email: Email,
        NationalCode: NationalCode

      }

    }).pipe(
      catchError(this.handleError)
    );

  }
  //-------------------------------------------------
  //------------------------------------------------
  DeleteUserProfile_ID(ID: string, UserName: string) {
    this.configUrl = this.configUrlBasic + '/DeleteUserProfile/Get'
    return this.http.get(this.configUrl, {
      params: {
        ID: ID,
        UserName: UserName
      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  InserUserProfile(params: any) {
    this.configUrl = this.configUrlBasic + '/InsertUserProfile/Get'

    return this.http.get(this.configUrl, { params }

    ).pipe(
      catchError(this.handleError)
    );
  }
  UpdateUserProfile(params: any) {
    this.configUrl = this.configUrlBasic + '/UpdateUserProfile/Get'
    return this.http.get(this.configUrl, { params }

    ).pipe(
      catchError(this.handleError)
    );
  }
  //UserProfile*********************************************************************
  FetchUserRole_Filter(Lang: string, UserName: string) {
    this.configUrl = this.configUrlBasic + '/SelectUserRole/Get'

    return this.http.get<UserRole[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName
      }

    }).pipe(
      catchError(this.handleError)
    );
  }
  FetchUserRole_FilterID(Lang: string, UserName: string, ID: string) {
    this.configUrl = this.configUrlBasic + '/SelectUserRole/Get'

    return this.http.get<UserRole[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        ID: ID
      }

    }).pipe(
      catchError(this.handleError)
    );
  }
  //string Lang, string UserName, string RoleName, bool Active, int ? ParentLangID
  Fetch_FilterUserRoleGet(Lang: string, UserName: string, RoleName: string) {
    this.configUrl = this.configUrlBasic + '/SelectUserRole/Get'

    return this.http.get<UserRole[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        RoleName: RoleName
      }

    }).pipe(
      catchError(this.handleError)
    );

  }
  //-------------------------------------------------

  DeleteUserRole_ID(ID: string, UserName: string) {
    this.configUrl = this.configUrlBasic + '/DeleteUserRole/Get'
    return this.http.get(this.configUrl, {
      params: {
        ID: ID,
        UserName: UserName
      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  InserUserRole(params: any) {
    this.configUrl = this.configUrlBasic + '/InsertUserRole/Get'

    return this.http.get(this.configUrl, { params }

    ).pipe(
      catchError(this.handleError)
    );
  }
  UpdateUserRole(params: any) {
    this.configUrl = this.configUrlBasic + '/UpdateUserRole/Get'
    return this.http.get(this.configUrl, { params }

    ).pipe(
      catchError(this.handleError)
    );
  }


  //UserAccess**********************************************************************
  //---------------------------------UserSubMenu----------------------------------

  Fetch_FilterUserSubMenuGet(Lang: string, UserName: string, Title: string, ControlID: string, Active: string, IsShow: string) {
    this.configUrl = this.configUrlBasic + '/SelectUserSubMenu/Get'

    return this.http.get<Menu[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        Title: Title,
        ControlID: ControlID,
        Active: Active,
        IsShow: IsShow
      }

    }).pipe(
      catchError(this.handleError)
    );

  }
  //---------------------------------UserMenu------------------------------------

  Fetch_FilterUserMenuGet(Lang: string, UserName: string, Title: string, Active: string, IsShow: string) {
    this.configUrl = this.configUrlBasic + '/SelectUserMenu/Get'

    return this.http.get<Menu[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        Title: Title,
        Active: Active,
        IsShow: IsShow

      }

    }).pipe(
      catchError(this.handleError)
    );

  }
  //--------------------------------UserNotAcessMenu----------------------------

  Fetch_FilterUserNotAcessMenuGet(Lang: string, UserName: string, RoleID: string, Title: string, ControlID: string, Active: string, IsShow: string) {
    this.configUrl = this.configUrlBasic + '/SelectUserNotAcessMenu/Get'
      ;
    return this.http.get<Menu[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        Title: Title,
        ControlID: ControlID,
        Active: Active,
        IsShow: IsShow,
        RoleID: RoleID
      }

    }).pipe(
      catchError(this.handleError)
    );

  }
  //---------------------------------UserAcessMenu-----------------------------------
  Fetch_FilterUserAcessMenuGet(Lang: string, UserName: string, RoleID: string, Title: string, ControlID: string, Active: string, IsShow: string) {
    this.configUrl = this.configUrlBasic + '/SelectUserAccessMenu/Get'

    return this.http.get<Menu[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        Title: Title,
        ControlID: ControlID,
        Active: Active,
        IsShow: IsShow,
        RoleID: RoleID

      }

    }).pipe(
      catchError(this.handleError)
    );

  }

  DeleteUserAcess_ID(ID: string, UserName: string) {
    this.configUrl = this.configUrlBasic + '/DeleteUserAccess/Get'
    return this.http.get(this.configUrl, {
      params: {
        ID: ID,
        UserName: UserName
      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  InserUserAcess(params: any) {
    this.configUrl = this.configUrlBasic + '/InsertUserAccess/Get'

    return this.http.get(this.configUrl, { params }

    ).pipe(
      catchError(this.handleError)
    );

  }

  //--8:51:44 PM Monday, March 1, 2021
  //PageGenerator*********************************************************************
  Fetch_FilterPageGeneratorGet(Lang: string, LogUser: string, CompanyID: string, ID: string, PageContent: string, PageLocationID: string, Active: string) {
    this.configUrl = this.configUrlBasic + '/SelectPageGenerator/Get'
    return this.http.get<PageGenerator[]>(this.configUrl, {
      params: {
        Lang: Lang,
        LogUser: LogUser,
        CompanyID: CompanyID,
        ID: ID,
        PageContent: PageContent,
        PageLocationID: PageLocationID,
        Active: Active
      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  Fetch_FilterPageGenerator(Lang: string, UserName: string) {
    this.configUrl = this.configUrlBasic + '/SelectPageGenerator/Get'
    return this.http.get<PageGenerator[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName
      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  Fetch_FilterPageGeneratorID(Lang: string, UserName: string, ID: string) {
    this.configUrl = this.configUrlBasic + '/SelectPageGenerator/Get'
    return this.http.get<PageGenerator>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        ID: ID
      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  Fetch_FilterPageGeneratorCompanyID(Lang: string, UserName: string, CompanyID: string) {
    this.configUrl = this.configUrlBasic + '/SelectPageGenerator/Get'
    return this.http.get<PageGenerator[]>(this.configUrl, {
      params: {

        CompanyID: CompanyID
      }
    }).pipe(
      catchError(this.handleError)
    );
  }

  //--10:22:41 PM Monday, March 1, 2021
  //PageGenerator*********************************************************************
  //InsertPageGenerator---------------------------------------------------------------
  InsertPageGenerator(params: any) {
    this.configUrl = this.configUrlBasic + '/InsertPageGenerator/Get'
    return this.http.get(this.configUrl, { params }
    ).pipe(
      catchError(this.handleError)
    );
  }
  //UpdatePageGenerator---------------------------------------------------------------
  UpdatePageGenerator(params: any) {
    this.configUrl = this.configUrlBasic + '/UpdatePageGenerator/Get'
    return this.http.get(this.configUrl, { params }
    ).pipe(
      catchError(this.handleError)
    );
  }
  //DeletePageGenerator---------------------------------------------------------------
  DeletePageGeneratorID(ID: string, UserName: string, Lang: string) {
    this.configUrl = this.configUrlBasic + '/DeletePageGenerator/Get'
    return this.http.get(this.configUrl, {
      params: {
        ID: ID,
        UserName: UserName,
        Lang: Lang
      }
    }).pipe(
      catchError(this.handleError)
    );
  }


  //--10:34:07 PM Monday, March 22, 2021
  //VisitedHistory*********************************************************************
  Fetch_FilterVisitedHistoryGet(CompanyID: string, durationDay: string) {
    this.configUrl = this.configUrlBasic + '/VisitedHistory/Get'
    return this.http.get<VisitedHistory[]>(this.configUrl, {
      params: {

        CompanyID: CompanyID,
        durationDay: durationDay
      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  Fetch_FilterVisitedHistory(Lang: string, UserName: string) {
    this.configUrl = this.configUrlBasic + '/VisitedHistory/Get'
    return this.http.get<VisitedHistory[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName
      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  Fetch_FilterVisitedHistoryID(Lang: string, UserName: string, ID: string) {
    this.configUrl = this.configUrlBasic + '/VisitedHistory/Get'
    return this.http.get<VisitedHistory>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        ID: ID
      }
    }).pipe(
      catchError(this.handleError)
    );
  }

  //--------------------RestaurantSetting----------------------------------
  FetchCompanySetting(Lang: string, UserName: string, CompanyID: string, Category: string) {
    this.configUrl = this.configUrlBasic + '/SelectRestaurantSetting/'
    return this.http.get<CompanySettings[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        CompanyID: CompanyID,
        Category: Category

      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  InsertCompanySetting(Postdata: any) {
    this.configUrl = this.configUrlBasic + '/InsertRestauranSetting/post'
    return this.http.post(this.configUrl, { Postdata }
    ).pipe(
      catchError(this.handleError)
    );
  }


  //--1:25:53 PM Tuesday, April 6, 2021
  //PageMenu*********************************************************************
  Fetch_FilterPageMenuGet(Lang: string, UserName: string, CompanyID: string) {
    this.configUrl = this.configUrlBasic + '/SelectPageMenu/Get'
    return this.http.get<PageMenu[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        CompanyID: CompanyID,
      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  Fetch_FilterPageMenu(Lang: string, UserName: string) {
    this.configUrl = this.configUrlBasic + '/SelectPageMenu/Get'
    return this.http.get<PageMenu[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName
      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  Fetch_FilterPageMenuID(Lang: string, UserName: string, ID: string) {
    this.configUrl = this.configUrlBasic + '/SelectPageMenu/Get'
    return this.http.get<PageMenu>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        ID: ID
      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  Fetch_FilterPageMenuActive() {
    this.configUrl = this.configUrlBasic + '/SelectMenuPageActive/Get'
    return this.http.get<MenuView[]>(this.configUrl).pipe(
      catchError(this.handleError)
    );
  }
  //--1:26:19 PM Tuesday, April 6, 2021
  //PageMenu*********************************************************************
  //InsertPageMenu---------------------------------------------------------------
  InsertPageMenu(params: any) {
    this.configUrl = this.configUrlBasic + '/InsertPageMenu/Get'
    return this.http.get(this.configUrl, { params }
    ).pipe(
      catchError(this.handleError)
    );
  }
  //UpdatePageMenu---------------------------------------------------------------
  UpdatePageMenu(Postdata: any) {
    this.configUrl = this.configUrlBasic + '/UpdatePageMenu/Post'
    return this.http.post(this.configUrl, { Postdata }
    ).pipe(
      catchError(this.handleError)
    );
  }
  //DeletePageMenu---------------------------------------------------------------
  DeletePageMenuID(ID: string, UserName: string, Lang: string) {
    this.configUrl = this.configUrlBasic + '/DeletePageMenu/Get'
    return this.http.get(this.configUrl, {
      params: {
        ID: ID,
        UserName: UserName,
        Lang: Lang
      }
    }).pipe(
      catchError(this.handleError)
    );
  }


  //--1:08:28 PM Monday, May 3, 2021
  //Payment*********************************************************************
  Fetch_FilterPaymentGet(Lang: string, UserName: string, ID: string, CompanyID: string, PurchaseID: string, FromDate: string, ToDate: string, FullName: string, Status: string) {
    this.configUrl = this.configUrlBasic + '/SelectPayment/Get'
    return this.http.get<Payment[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        ID: ID,
        CompanyID: CompanyID,
        PurchaseID: PurchaseID,
        FromDate: FromDate,
        ToDate: ToDate,
        FullName: FullName,
        Status: Status,
      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  Fetch_FilterPayment(Lang: string, UserName: string) {
    this.configUrl = this.configUrlBasic + '/SelectPayment/Get'
    return this.http.get<Payment[]>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName
      }
    }).pipe(
      catchError(this.handleError)
    );
  }
  Fetch_FilterPaymentID(Lang: string, UserName: string, ID: string) {
    this.configUrl = this.configUrlBasic + '/SelectPayment/Get'
    return this.http.get<Payment>(this.configUrl, {
      params: {
        Lang: Lang,
        UserName: UserName,
        ID: ID
      }
    }).pipe(
      catchError(this.handleError)
    );
  }

}
//-------------------------------
