import { useForm } from 'react-hook-form';
import { RegFormData } from '../models/types';
import { useNavigate } from 'react-router-dom';
import { SignupRequest } from '@/shared/api/types';
import { reatomComponent } from '@reatom/npm-react';
import { signupAction } from '@/entities/User';
import './AuthForm.scss';

export const SignUpForm = reatomComponent(({ ctx }) => {
    const navigate = useNavigate();

    const {
        register,
        formState: { isValid },
        handleSubmit,
    } = useForm<RegFormData>();

    const onSignUp = async (data: SignupRequest) => {
        await signupAction(ctx, data);
        navigate('/login');
    };

    return (
        <form
            className="authForm"
            onSubmit={handleSubmit(onSignUp)}
        >
            <input
                {...register('userName', {
                    required: true,
                })}
                placeholder="Логин"
                className="authForm__input"
            />
            <input
                {...register('email', {
                    required: true,
                })}
                type="password"
                placeholder="Пароль"
                className="authForm__input"
            />
            <input
                {...register('password', {
                    required: true,
                })}
                type="password"
                placeholder="Пароль"
                className="authForm__input"
            />
            <button
                disabled={!isValid}
                type="submit"
                className="authForm__submit"
            >
                Зарегистрироваться
            </button>
        </form>
    );
}, 'SignUpForm');
