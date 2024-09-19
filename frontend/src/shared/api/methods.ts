import { LoginRequest, LoginResponse, SignupRequest, UserInfo } from './types';
import { httpClient } from './httpClient';

export const signupRequest = async (data: SignupRequest) =>
    (await httpClient.post('/api/users/Auth/register', data)).data as number;

export const loginRequest = async (data: LoginRequest) =>
    (await httpClient.post('/api/users/Auth/login', data)).data as LoginResponse;

export const userInfoRequest = async () =>
    (await httpClient.get('/api/users/info')).data as UserInfo;
