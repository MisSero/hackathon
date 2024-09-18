import clsx from 'clsx';
import { ReactNode } from 'react';
import { Link } from 'react-router-dom';
import './Card.scss';

type Card = {
    className?: string;
    img: string;
    title: string;
    link: string;
    description: string;
    info: string | ReactNode;
};

export const Card = (props: Card) => (
    <article className={clsx('card', props.className)}>
        <img
            className="card__img"
            src={props.img}
            alt={`Card image`}
        />
        <section className="card__data">
            <Link
                className="card__title unsettedLink"
                to={props.link}
            >
                {props.title}
            </Link>
            <p className="card__description">{props.description}</p>
            <p className="card__info">{props.info}</p>
        </section>
    </article>
);
