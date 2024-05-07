import React from "react";
import { CompanyTenK } from "../../../company";
import { Link } from "react-router-dom";

type Props = {
	tenK: CompanyTenK;
};

const TenKFinderItem = ({ tenK }: Props) => {
	const fillingDate = new Date(tenK.fillingDate).getFullYear();

	return (
		<Link
			reloadDocument
			to={tenK.finalLink}
			type="button"
			className="inline-flex items-center px-4 py-2 text-sm font-medium mr-2 text-white bg-lightGreen hover:bg-green-500 rounded-md"
		>
			10K - {tenK.symbol} - {fillingDate}
		</Link>
	);
};

export default TenKFinderItem;
