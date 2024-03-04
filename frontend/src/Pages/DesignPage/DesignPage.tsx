import React from "react";
import Table from "../../Components/Table/Table";
import RatioList from "../../Components/RatioList/RatioList";

type Props = {};

const DesignPage = (props: Props) => {
	return (
		<>
			<h1>
				Design Guide - This is Finshark's design page. This is where we will
				house variable design aspects of the app
			</h1>
			<RatioList />
			<Table />
		</>
	);
};

export default DesignPage;
