import { useForm } from 'react-hook-form';
import { AuthFormData, RegFormData } from '../models/types';
import { useNavigate } from 'react-router-dom';
import './AuthForm.scss';

export const SignUpForm = () => {
    const navigate = useNavigate();

    const {
        register,
        formState: { isValid },
        handleSubmit,
    } = useForm<RegFormData>();

    const onLogIn = async (data: AuthFormData) => {
        console.log(data);
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
};
