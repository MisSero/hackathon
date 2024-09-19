export type LoginRequest = {
    userName: string;
    password: string;
};

export type SignupRequest = LoginRequest & {
    email: string;
};

export type LoginResponse = {
    id: number;
    jwtToken: string;
};

export type UserInfo = {
    id: number;
    userName: string;
    email: string;
    creationDate: string;
    role: string;
    gender?: number;
    age?: number;
    city: string;
};
