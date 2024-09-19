import { LoginRequest, LoginResponse, SignupRequest, UserInfo } from './types';
import { httpClient } from './httpClient';

export const signupRequest = async (data: SignupRequest) =>
    (await httpClient.post('/api/users/Auth/register', data)).data as number;

export const loginRequest = async (data: LoginRequest) =>
    (await httpClient.post<LoginResponse>('/api/users/Auth/login', data)).data;

export const userInfoRequest = async () => (await httpClient.get<UserInfo>('/api/users/info')).data;
