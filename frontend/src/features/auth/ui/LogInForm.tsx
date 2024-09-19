import { useForm } from 'react-hook-form';
import { AuthFormData } from '../models/types';
import { useNavigate } from 'react-router-dom';
import { reatomComponent } from '@reatom/npm-react';
import './AuthForm.scss';
import { loginAction } from '@/entities/User';

export const LogInForm = reatomComponent(({ ctx }) => {
    const navigate = useNavigate();

    const {
        register,
        formState: { isValid },
        handleSubmit,
    } = useForm<AuthFormData>();

    const onLogIn = async (data: AuthFormData) => {
        await loginAction(ctx, data);
        navigate('/');
    };

    return (
        <form
            className="authForm"
            onSubmit={handleSubmit(onLogIn)}
        >
            <input
                {...register('userName', {
                    required: true,
                })}
                placeholder="Логин"
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
                Войти
            </button>
        </form>
    );
});
