import axios from 'axios';
import { LoginRequest, SignupRequest, UserInfo } from './types';

export const signupRequest = async (data: SignupRequest) =>
    (await axios.post('/api/users/Auth/register', data)).data as number;

export const loginRequest = async (data: LoginRequest) =>
    (await axios.post('/api/users/Auth/login', data)).data;

export const userInfoRequest = async () => (await axios.get('/api/users/info')).data as UserInfo;
